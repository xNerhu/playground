#include <iostream>

int main()
{
	int sum = 0;
	int input;

	for (int i = 0; i < 3; i++) {
		std::cin >> input;
		sum += input;
	}

	std::cout << sum;
}