#include <Windows.h>
#include <iostream>


struct pixel {
	int r, g, b;
	pixel(int R, int G, int B) {
		r = R;
		g = G;
		b = B;
	}
	void set(int R, int G, int B) {
		r = R;
		g = G;
		b = B;
	}
	bool isBlack() {
		return (
			r <= 20 &&
			g <= 20 &&
			b <= 20
			);
	}
};

pixel getPixel(int x, int y) {
	pixel returnValue(-1, -1, -1);
	HDC hdcScreen = ::GetDC(NULL);
	COLORREF pixel = ::GetPixel(hdcScreen, x, y);
	ReleaseDC(NULL, hdcScreen);
	if (pixel != CLR_INVALID) {
		int red = GetRValue(pixel);
		int green = GetGValue(pixel);
		int blue = GetBValue(pixel);
		returnValue.set(red, green, blue);
	}
	return returnValue;
}

void LeftClick()
{
	INPUT    Input = { 0 };
	// left down 
	Input.type = INPUT_MOUSE;
	Input.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
	::SendInput(1, &Input, sizeof(INPUT));
	Sleep(10);
	// left up
	::ZeroMemory(&Input, sizeof(INPUT));
	Input.type = INPUT_MOUSE;
	Input.mi.dwFlags = MOUSEEVENTF_LEFTUP;
	::SendInput(1, &Input, sizeof(INPUT));
}

void waitForS(bool q = false) {
	while (!(GetKeyState('S') & 0x8000/*Check if high-order bit is set (1 << 15)*/)) {
		if (q) {
			if(GetKeyState('Q') & 0x8000/*Check if high-order bit is set (1 << 15)*/){
				return;
			}
		}
	}
}

void getPoint(int* px, int* py, std::string message) {
	POINT p;
	std::cout << message << " and press 'S'" << std::endl;
	Sleep(500);
	waitForS();
	GetCursorPos(&p);
	*px = p.x;
	*py += p.y;
}

int main() {
	
	std::cout << "press 'S' to start" << std::endl;
	waitForS();

	int points[4] = { 0 };
	int ypoint = 0;

	getPoint(&points[0], &ypoint, "set mouse first scan point");
	getPoint(&points[1], &ypoint, "set mouse seccond scan point");
	getPoint(&points[2], &ypoint, "set mouse third scan point");
	getPoint(&points[3], &ypoint, "set mouse fourth scan point");
	ypoint = (int)round((float)ypoint * 0.25);


	std::cout << "------------------------------------------" << std::endl;
	std::cout << "press 'S' to start; 'P' to pause; 'Q' to stop" << std::endl;
	Sleep(500);
	waitForS();
	std::cout << "running..." << std::endl;
	int lastclicked = -1;
	Sleep(500);
	while (true) {
		
		if (GetKeyState('P') & 0x8000/*Check if high-order bit is set (1 << 15)*/) {
			std::cout << "paused..." << std::endl;
			waitForS(true);
			std::cout << "unpaused..." << std::endl;
		}
		if (GetKeyState('Q') & 0x8000/*Check if high-order bit is set (1 << 15)*/)
		{
			return 0;
		}
		for (int i = 0; i < 4; i += 1) {
			pixel px = getPixel(points[i], ypoint);
			if (px.isBlack()) {
				if (lastclicked != i) {
					SetCursorPos(points[i], ypoint);
					LeftClick();
					//lastclicked = i;
				}
			}
		}
		Sleep(10);

	}
	return 0;
}