
#include <iostream>
#include <fstream>
using namespace std;

int main() {
	ifstream f1;
	char c;
	int numchars, numlines;

	f1.open("E:\\DoAn1\\pytorch.txt");

	numchars = 0;
	numlines = 0;
	f1.get(c);
	while (f1) {
		while (f1 && c != '\n') {
			numchars = numchars + 1;
			f1.get(c);
		}
		numlines = numlines + 1;
		f1.get(c);
	}
	cout << "File nay co " << numlines << " dong "
		<< endl;
	return(0);
}