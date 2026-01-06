#include <iostream>
#include <cmath>

using namespace std;

// Function to calculate roots of a quadratic equation
void findRoots(double a, double b, double c) {
    double discriminant = b * b - 4 * a * c;
    
    if (discriminant > 0) {
        double root1 = (-b + sqrt(discriminant)) / (2 * a);
        double root2 = (-b - sqrt(discriminant)) / (2 * a);
        cout << "Root 1: " << root1 << endl;
        cout << "Root 2: " << root2 << endl;
    } else if (discriminant == 0) {
        double root = -b / (2 * a);
        cout << "Double Root: " << root << endl;
    } else {
        cout << "No real roots" << endl;
    }
}

int main() {
    double a, b, c;
    
    cout << "Enter coefficients of quadratic equation (a, b, c): ";
    cin >> a >> b >> c;

    // Calculate and display roots
    cout << "Roots of the quadratic equation:" << endl;
    findRoots(a, b, c);

    // Perform Boundary Value Analysis
    cout << "\nPerforming Boundary Value Analysis (BVA):" << endl;

    // Test with small coefficients
    cout << "Testing with small coefficients:" << endl;
    findRoots(1e-6, 1e-6, 1e-6);

    // Test with large coefficients
    cout << "Testing with large coefficients:" << endl;
    findRoots(1e6, 1e6, 1e6);

    // Test with equal coefficients
    cout << "Testing with equal coefficients:" << endl;
    findRoots(1, 1, 1);

    return 0;
}