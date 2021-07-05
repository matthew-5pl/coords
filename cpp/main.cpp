#include <iostream>

using namespace std;

float randFloat(float inputMin, float inputMax) {
    float result = (float)rand()/(float)(RAND_MAX/inputMax);
    return result;
}

void generatePlat(float inputX, float inputY, float offsetXMin, float offsetYMin, float offsetXMax, float offsetYMax, int toBeGen) {
    for (int c = 0; c < toBeGen; c++) {
        float cordGenX = randFloat(offsetXMin, offsetXMax);
        float cordGenY = randFloat(offsetYMin, offsetYMax);
        float finalX = inputX + cordGenX;
        float finalY = inputY + cordGenY;
        cout << "Coords = X: " + to_string(finalX) + "; Y: " + to_string(finalY) + "\n";
    }
}

int main(int argc, char *argv[]) {
    float inputX = stof(argv[1]);
    float inputY = stof(argv[2]);
    float offsetXMin = stof(argv[3]);
    float offsetYMin = stof(argv[4]);
    float offsetXMax = stof(argv[5]);
    float offsetYMax = stof(argv[6]);
    int toBeGen = stoi(argv[7]);
    generatePlat(inputX, inputY, offsetXMin, offsetXMax, offsetYMin, offsetYMax, toBeGen);
}
