#include <iostream>
#include <stdexcept>

class FactorialCalculator {
private:
    
public:
    // Method to calculate the factorial of a number
    static long long calculate(long long number) {
        if (number < 0) {
            throw std::invalid_argument("Number must be non-negative.");
        }

        return number == 0 ? 1 : number * calculate(number - 1);
    }

    static int* returnsum(){
        int* a = new int[10];
        int* b = new int[10];
        int* c;
        for(int i = 0;i<10;i++){c[i] + a[i]+b[i]}
        return c
    }
};

int main() {
    try {
        std::cout << "Enter a number: ";
        long long number;
        std::cin >> number;
        long long result = FactorialCalculator::calculate(number);
        std::cout << "Factorial of " << number << " is " << result << std::endl;
    } catch (const std::exception& ex) {
        std::cout << "Error: " << ex.what() << std::endl;
    }

    return 0;
}
