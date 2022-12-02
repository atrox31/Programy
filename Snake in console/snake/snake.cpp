#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <math.h>
#include <string>

using namespace std;

/*
	GLOBALNE ZMIENNE
*/

// struktura punktu (x,y)
struct point {
	int x;
	int y;
};

// typ kierunku
enum directions {
	dir_up,
	dir_right,
	dir_down,
	dir_left,
	dir_none
};

// gameplay vars
int		score;
int		lives;

// system vars
HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
const int	mapWidth = 20;
const int	mapHeight = 15;
point		snakeHead;
point		pointHead;
int			snakeTail[mapWidth][mapHeight];
int			snakeTailElements;
int			pointToCollect;
int			pointStartValue = 50;
int			pointDecOverTime = 1;
int			pointMinValue = 5;
point		snakeDirection;

//	default vars
const int default_score = 0;
const int default_lives = 3;
const int default_snakeTailElements = 3;

// graph
const char mapField_none = ' ';
const char mapField_head = '#';
const char mapField_tail = '*';
const char mapField_point = '$';
const char mapField_wall = '+';

// klawisze
const short unsigned int KeyLeft = 37;
const short unsigned int KeyTop = 38;
const short unsigned int KeyRight = 39;
const short unsigned int KeyDown = 40;
const short unsigned int KeyExit = 81;
const short unsigned int KeyEnter = 38;

/*
	FUNKCJE
*/


// ustawia nową pozycję punktu sprawdzając czy nei ma tam ogona
// ! tam gdzie głowa tam zawsze najwyższa wartość snakeTail więc tez w głowie się nie zrobi
void setNewPointHead() {
	int newX, newY;
	while (true) {
		newX = rand() % mapWidth;
		newY = rand() % mapHeight;
		if (snakeTail[newX][newY] == 0) {
			pointHead.x = newX;
			pointHead.y = newY;
			return;	// wyłamuje z pętli while(true)
		}
	}
}
// akcja gdy zbierze się punkt
void getPoints() {
	score += pointToCollect;
	pointToCollect = pointStartValue;
	snakeTailElements++;
	setNewPointHead();
}
// akcja sprawdzenia czy głowa nie weszła w ogon
bool checkTail() {
	for (int y = 0; y < mapHeight; y++)
	{
		for (int x = 0; x < mapWidth; x++)
		{
			if (snakeHead.x == x && snakeHead.y == y) {
				// sprawdź czy głowa jest na ogonie
				if (snakeTail[x][y] < snakeTailElements) {
					// ewidentnie ogon
					return false;
				}
			}
			else {
				// jak nie głowa na ogonie to go zmniejsz
				if (snakeTail[x][y] > 0) {
					snakeTail[x][y]--;
				}
			}
		}
	}
	// zwraca że wszystko ok
	return true;
}
void drawMap() {
	for (int y = -1; y <= mapHeight; y++)
	{
		for (int x = -1; x <= mapWidth; x++)
		{
			if (y == -1 || x == -1 || x == mapWidth || y == mapHeight) {
				SetConsoleTextAttribute(hConsole, 2);
				cout << mapField_wall;
			}
			else {


				char draw = mapField_none;
				SetConsoleTextAttribute(hConsole, 0);
				if (pointHead.x == x && pointHead.y == y) {
					// draw point
					SetConsoleTextAttribute(hConsole, 4);
					draw = mapField_point;
				}
				else
					if (snakeHead.x == x && snakeHead.y == y) {
						// draw point
						SetConsoleTextAttribute(hConsole, 6);
						draw = mapField_head;
					}
					else
						if (snakeTail[x][y] > 0) {
							SetConsoleTextAttribute(hConsole, 8);
							draw = mapField_tail;
						}
				cout << draw;
			}
		}
		cout << endl;
	}
	cout << "\n\n" << "\t\tScore: " << score << "\n\t\tLives: " << lives;
}
void setDirection(directions newDirection) {
	switch (newDirection)
	{
		 case dir_up:
			snakeDirection.x = 0;
			snakeDirection.y = -1;
		break;

		 case dir_right:
			snakeDirection.x = 1;
			snakeDirection.y = 0;
		break;

		 case dir_down:
			snakeDirection.x = 0;
			snakeDirection.y = 1;
		break;

		 case dir_left:
			snakeDirection.x = -1;
			snakeDirection.y = 0;
		break;

	}
}
void snakeMove() {
	snakeHead.x += snakeDirection.x;
	snakeHead.y += snakeDirection.y;
	// wraca na przeciwny koniec mapy
	if (snakeHead.x == mapWidth) {
		snakeHead.x = 0;
	}
	if (snakeHead.x == 0 - 1) {
		snakeHead.x = mapWidth - 1;
	}

	if (snakeHead.y == mapHeight) {
		snakeHead.y = 0;
	}
	if (snakeHead.y == 0 - 1) {
		snakeHead.y = mapHeight - 1;
	}
	if (snakeTail[snakeHead.x][snakeHead.y] == 0) {
		snakeTail[snakeHead.x][snakeHead.y] = snakeTailElements;
	}
}
void prepareGame( bool newGame) {
	// ustawia domyślne wartości
	if (newGame) {
		score = default_score;
		lives = default_lives;
	}
	// głowa węża znajduje się na środku mapy
	snakeHead.x = (int)round((double)mapWidth / 2);
	snakeHead.y = (int)round((double)mapHeight / 2);
	// czyść tablice z ogonem
	for (int y = 0; y < mapHeight; y++)
	{
		for (int x = 0; x < mapWidth; x++)
		{
			snakeTail[x][y] = 0;
		}
	}
	// długość węża
	snakeTailElements = default_snakeTailElements;
	// nowa pozycja punktu
	setNewPointHead();
	// nadaj początkowy kierunek
	setDirection(dir_right);
}
directions getUserInput() {
	if (GetAsyncKeyState(KeyLeft) != 0) {
		return dir_left;
	}
	if (GetAsyncKeyState(KeyRight) != 0) {
		return dir_right;
	}
	if (GetAsyncKeyState(KeyTop) != 0) {
		return dir_up;
	}
	if (GetAsyncKeyState(KeyDown) != 0) {
		return dir_down;
	}
	return dir_none;
}

// główna funkcja programu
int main()
{
	cout << "Snake game!" << endl;
	system("pause");
	prepareGame(true);
	while (true) {
		while (true) {
			system("cls");
			setDirection(getUserInput());
			snakeMove();
			if (checkTail()) {
				if (pointHead.x == snakeHead.x && pointHead.y == snakeHead.y) {
					getPoints();
					setNewPointHead();
					Beep(1200, 120);
				}
				else {
					if (pointToCollect > pointMinValue) {
						pointToCollect -= pointDecOverTime;
					}
				}
			}
			else {
				break;
			}
			drawMap();
			Sleep(133);
		}
		lives--;
		system("cls");
		cout << "You Lose!" << endl;
		cout << "Score: " << score << endl;
		cout << "Lives: " << lives << endl;
		Beep(1200, 800);
		Beep(1000, 800);
		Beep(800, 800);
		if (lives > 0) {
			system("pause");
			prepareGame(false);
		}
		else {
			break;
		}
	}
	system("cls");
	cout << "Game Over!" << endl;
	cout << "Score: " << score << endl;
	system("pause");
	return 0;
}
