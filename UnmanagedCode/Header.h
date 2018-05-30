#pragma once

class LowLevel3DArithmetic {
public:
	LowLevel3DArithmetic(double baseOx, double baseOy, double baseOz);
	double DistanceFromZeroToBasePoint();
private:
	double _baseOx, _baseOy, _baseOz;
	double _zeroOx, _zeroOy, _zeroOz;
};
