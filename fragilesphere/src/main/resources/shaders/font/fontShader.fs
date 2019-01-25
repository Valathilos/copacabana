#version 430

in vec2 pass_textureCoords;

out vec4 out_Colour;

uniform vec3 colour;
uniform sampler2D fontAtlas;

const float width = 0.53;
const float edge = 0.11;
//const float width = 0.5;
//const float edge = 0.1;

void main(void){
	float distance = 1.0 - texture(fontAtlas, pass_textureCoords).a;
	float alpha = 1.0 - smoothstep(width, width + edge, distance);
	out_Colour = vec4(colour, alpha);
	//out_Colour = vec4(colour, texture(fontAtlas, pass_textureCoords).a);
}