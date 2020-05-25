#pragma once
#include <GL/glew.h>
#include <GL/glut.h>
class FixedFunctionRenderer
{
public:

	FixedFunctionRenderer();
	void renderSquare(float scl = 1.0f, float tx = 0.0f, float ty = 0.0f);
};

