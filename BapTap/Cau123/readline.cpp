#include <iostream>
#include <fstream>
#include <string>
using namespace std;
#define MAX 19
bool ReadFile(const char filename[], char a[][MAX]);
void XuatFile(char a[][MAX], int& d, int& c);
int main() 
{
	int numlines;
	char c;
	int d, cot;
	int dem1=1;
	char a[MAX][MAX];
	ReadFile("E:\\DoAn1\\pytorch.txt", a);
	XuatFile(a,d,cot);
	for(int i =0; i < d ;i++)
		for (int j = 0; j < cot; j++)
		{
			if (a[i][j] == '\n')
			{
				dem1++;


			}

			if ((a[i][j] == 'c') || (a[i][j] == 'C') && (a[i][j + 1] == 'l') || (a[i][j + 1] == 'L') && (a[i][j + 2] == 'a') || (a[i][j + 2] == 'A')
				&& (a[i][j + 3] == 's') || (a[i][j + 3] == 'S') && (a[i][j + 4] == 's') || (a[i][j + 4] == 'S'))
			{
				cout << endl;
				cout << " tu khoa class nam o dong: ";
				cout << dem1;
				break;

			}
		}

		
	return 0;
}

bool ReadFile(const char filename[], char a[][MAX]) {

	FILE* fp;
	fopen_s(&fp, filename, "rt");
	if (fp == NULL)
	{
		cout << "khong mo duoc tap tin!\n";
		return false;
	}
	string str1 = "class ";
	for (int i = 0; i < MAX; i++)
		for (int j = 0; j < MAX; j++) {
			

			fscanf_s(fp, "%c", &a[i][j]);	
		}

	fclose(fp);
	return true;
}

void XuatFile(char a[][MAX], int &d, int &c) {
	int dem = 1;
	for (int i = 0; i < MAX; i++)
	{
		
		for (int j = 0; j < MAX; j++)
		{
			
			cout << a[i][j]; 
			if (a[i][j] == '\n')
			{
				dem++;
				
			}
			
			if (a[i][j] == ';')
			{
				
				cout << endl;
				cout << " File nay co ";
				cout << dem;
				d = dem;
				c = i;
				cout << " dong";
					
				return;
			
			}
			
		}
			
	}
	

	
}
