#ifndef GAME_H
#define GAME_H

#include <iostream>

#include "glew-1.13.0\include\GL\glew.h"
#include "glew-1.13.0\include\GL\wglew.h"

#include <gl\GL.h>
#include <gl\GLU.h>

#include "glm-0.9.8.4\glm\glm.hpp"
#include "glm-0.9.8.4\glm\gtc\matrix_transform.hpp"

#include "SFML-2.3.2\include\SFML\Graphics.hpp"
#include "SFML-2.3.2\include\SFML\OpenGL.hpp"
#include "SFML-2.3.2\include\SFML\Window.hpp"

#include <Debug.h>

#define STB_IMAGE_IMPLEMENTATION
#include <stb_image.h>

using namespace std;
using namespace sf;
using namespace glm;

class Game
{
public:
	Game();
	Game(sf::ContextSettings settings);
	~Game();
	void run();
	void render();
private:
	//Window window;
	RenderWindow renderWindow;
	View mainView;
	bool isRunning = false;
	void initialize();
	void update();
	void unload();

	float turnSpeed = 0.05f;
};

#endif