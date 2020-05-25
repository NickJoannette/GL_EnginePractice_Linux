#version 330 core
out vec4 FragColor;

in vec2 TexCoords;
uniform vec3 testColor;
uniform sampler2D texture_diffuse1;

void main()
{
//FragColor = vec4(testColor.rgb,1.0);
    FragColor = texture(texture_diffuse1, TexCoords);
}
