#include <iostream>
#include <string>

typedef std::uint8_t suint;

int main()
{
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(NULL);

    std::string str;
    std::cin >> str;
    
    for (suint i = 0; i < str.length(); i++) {
        std::cout << str << " ";
    }
}