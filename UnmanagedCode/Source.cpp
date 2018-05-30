#pragma once
#include "Header.h"
#include<cmath>

LowLevel3DArithmetic::LowLevel3DArithmetic(double baseOx, double baseOy, double baseOz) {
	_baseOx = baseOx;
	_baseOy = baseOy;
	_baseOz = baseOz;
	_zeroOx = _zeroOy = _zeroOz = 0.0;
}

double LowLevel3DArithmetic::DistanceFromZeroToBasePoint() {
	return sqrt(pow(_zeroOx - _baseOx, 2) +
		(pow(_zeroOy - _baseOy, 2)) +
		(pow(_zeroOz - _baseOz, 2)));
}
