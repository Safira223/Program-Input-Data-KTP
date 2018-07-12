#include <iostream>
#include <conio.h>
using namespace std;
int main ()
{
    char nik [30];
	char nama [30];
    char tempattgllahir [50];
    char jeniskelamin [30];
    char alamat [50];
    char agama [20];
    char statusperkawinan [30];
    char pekerjaan [20];
    char kewarganegaraan [20];
    
	cout<<"\nInput Data KTP\n";
    cout<<"\nNIK\t\t : ";
    cin.getline(nik,30);
    cout<<"Nama\t\t : ";
    cin.getline(nama,30);
    cout<<"Tempat/Tgl Lahir : ";
    cin.getline(tempattgllahir,50);
    cout<<"Jenis Kelamin\t : ";
    cin.getline(jeniskelamin,30);
	cout<<"Alamat\t\t : ";
	cin.getline(alamat,50);
	cout<<"Agama\t\t : ";
	cin.getline(agama,20);
	cout<<"Status Perkawinan : ";
	cin.getline(statusperkawinan,30);
	cout<<"Pekerjaan\t : ";
	cin.getline(pekerjaan,20);
	cout<<"Kewarganegaraan : ";
	cin>>kewarganegaraan;
	
getch();
}
	  
    
    
