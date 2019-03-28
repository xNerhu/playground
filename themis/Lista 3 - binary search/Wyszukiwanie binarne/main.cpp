#include <iostream>

int binarySearch(const int *arr, const int &size, const int &searched) {
    int low = 0;
    int high = size - 1;
    int mid;

    while (low <= high) {
        mid = low + (high - low) / 2;

        if (arr[mid] < searched) {
            if (arr[mid + 1] < searched && mid + 1 < size) {
                low = mid + 1;
            } else {
                return mid;
            }
        } else {
            high = mid - 1;
        }
    }
    
    return -1;
}

int main() {
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(NULL);

    int n;
    int m;
    int temp;
    int *arr;

    std::cin >> n;

    arr = new int[n];

    for (int i = 0; i < n; i++) {
        std::cin >> temp;
        arr[i] = temp;
    }

    std::cin >> m;

    for (int i = 0; i < m; i++) {
        std::cin >> temp;
        std::cout << (n - binarySearch(arr, n, temp) - 1) << "\n";
    }

    delete[] arr;
}