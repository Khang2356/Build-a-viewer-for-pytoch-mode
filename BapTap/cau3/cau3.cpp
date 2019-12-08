
#include <iostream>
#include <string>
#include <fstream>
#include <iomanip> 
using namespace std;

int main(int argc, char* argv[])
{
	int counter = 0;
	unsigned int pos;
	bool wordFound;
	string fileName,
		word,
		templine,
		newLine;

	if (argc > 1)
		fileName = argv[1];
	else
	{
		cout << "Nhap duong dan toi file text ";
		getline(cin, fileName);

	}

	ifstream wordfile(fileName.data());

	if (!wordfile)
	{
		perror(fileName.data());
		exit(1);
	}
	cout << " Nhap tu can tim";
	getline(cin, word);

	while (getline(wordfile, templine))
	{
		pos = 0;
		wordFound = true;
		counter++;

		newLine = templine;
		while ((pos = newLine.find(word, pos)) < templine.npos)
		{
			if (wordFound)
			{
				cout << right << setw(5) << counter << ": " << left << templine << endl;
				wordFound = false;
			}
			newLine = newLine.substr(pos + (word.length()));
			pos = 0;
		}
	}

	return 0;
}