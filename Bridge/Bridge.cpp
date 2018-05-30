#include <string>
#include "C:\Users\Iskander\source\repos\Solution2\UnmanagedCode\Header.h"
#include "C:\Users\Iskander\source\repos\Solution2\UnmanagedCode\Source.cpp"

extern "C" __declspec(dllexport)
double DistanceFromZeroToBasePoint(double baseOx, double baseOy, double baseOz) {
	LowLevel3DArithmetic ll3da(baseOx, baseOy, baseOz);

	return ll3da.DistanceFromZeroToBasePoint();
}

extern "C" __declspec(dllexport)
int * GetSomeRandomPointer() {
	int randomValue = 777;
	return &randomValue;
}

extern "C" __declspec(dllexport)
void GetSomeString(char * str, int len) {
	str = new char [len] {'A', 'B', 'C', 'D'};
}


extern "C" __declspec(dllexport)
int * GetIntArray() {
	int * arr = new int [5]{ 1, 2, 3, 4, 5 };
	return arr;
}