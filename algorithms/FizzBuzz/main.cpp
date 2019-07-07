#include <iostream>
#include <string>

int main()
{
    int list[15] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

    for (int i = 0; i < (sizeof(list) / sizeof(*list)); i++) {
        std::string str;

        if (list[i] % 15 == 0) {
            str = "fizz buzz";
        } else if (list[i] % 3 == 0) {
            str = "fizz";
        } else if (list[i] % 5 == 0) {
            str = "buzz";
        }

        std::cout << list[i] << " " << str << "\n";
    }
}