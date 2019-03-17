
#include <iostream>
#include <string>

int main()
{
	std::uint32_t n;
	std::cin >> n;

	std::uint32_t* nums = new std::uint32_t[n];
	for (int i = 0; i < n; i++) {
		std::cin >> nums[i];
	}

	std::uint32_t* prefixSum = new std::uint32_t[n + 1];
	prefixSum[0] = 0;

	std::string str = "";

	for (int i = 1; i <= n; ++i) {
		prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
		str += std::to_string(prefixSum[i]);
		if (i < n) str += ' ';
	}

	std::cout << str;

	delete[] nums;
	delete[] prefixSum;
}