#include <iostream>
#include <string.h>
#define N 3
using namespace std;

class Student
{
public:
	char name[20];
	char personal_info[20];
	char courses[N][20];
	float grades[N];
	Student(char nume[20],char ps[20],char curs[N][20], float nota[N])
	{
	    strcpy(name,nume);
		strcpy(personal_info,ps);
		for(int i=0;i<N;i++)
        {
            strcpy(courses[i],curs[i]);
            grades[i] = nota[i];
        }
	}
	virtual void afisare()
	{
	    cout<<endl<<"Nume: "<<name;
	    cout<<endl<<"Informatii personale: "<<personal_info;
	    for(int i=0;i<N;i++)
        {
            cout<<endl<<"Cursuri: "<<courses[i];
            cout<<endl<<"Note: "<<grades[i];
        }
	}

};
/**/
class SoftwareStud:public Student
{
	char spec_curs[20];
	char list_prog[20];
public:
	SoftwareStud(char nume[20],char ps[20],char curs[N][20], float nota[N],char spec_c[20],char l_prog[20]): Student(nume,ps,curs,nota)
	{
	    strcpy(spec_curs,spec_c);
		strcpy(list_prog,l_prog);
	}
	void afisare()
	{
	    Student::afisare();
	    cout<<endl<<"Specializare curs: "<<spec_curs;
	    cout<<endl<<"List_prog: "<<list_prog;
	}

    void grade()
	{
	    int temp_good=0;
	    int temp_bad=0;
	    string temp_course_good;
	    string temp_course_bad;
	    for(int i=0;i<N;i++)
        {
            if(temp_good<grades[i])
            {
                temp_good=grades[i];
                temp_course_good=courses[i];
            }
            else
            {
                temp_bad=grades[i];
                temp_course_bad=courses[i];
            }
        }
        cout<<endl<<endl<<"Cursul cu cea mai buna nota este: "<<temp_course_good;
        cout<<endl<<"Cu nota: "<<temp_good;

        cout<<endl<<endl<<"Cursul cu cea mai rea nota este: "<<temp_course_bad;
        cout<<endl<<"Cu nota: "<<temp_bad;
	}


	float average()
	{
	    float temp=0;
	    for(int i=0;i<N;i++)
        {
            temp += grades[i];
        }

        return temp/N;
	}
};

class HardwareStud:public Student
{
	char spec_curs[20];
	char field[20];
public:
	HardwareStud(char nume[20],char ps[20],char curs[N][20], float nota[N],char s_curs[20],char f[20]):Student(nume,ps,curs,nota)
	{
		strcpy(spec_curs,s_curs);
		strcpy(field,f);
	}
	void afisare()
	{
	    Student::afisare();
	    cout<<endl<<"Spec_curs: "<<spec_curs;
	    cout<<endl<<"Field: "<<field;
	}

	void grade()
	{
	    int temp_good=0;
	    int temp_bad=0;
	    string temp_course_good;
	    string temp_course_bad;
	    for(int i=0;i<N;i++)
        {
            if(temp_good<grades[i])
            {
                temp_good=grades[i];
                temp_course_good=courses[i];
            }
            else
            {
                temp_bad=grades[i];
                temp_course_bad=courses[i];
            }
        }
        cout<<endl<<endl<<"Cursul cu cea mai buna nota este: "<<temp_course_good;
        cout<<endl<<"Cu nota: "<<temp_good;

        cout<<endl<<endl<<"Cursul cu cea mai rea nota este: "<<temp_course_bad;
        cout<<endl<<"Cu nota: "<<temp_bad;
	}

	float average()
	{
	    float temp=0;
	    for(int i=0;i<N;i++)
        {
            temp += grades[i];
        }

        return temp/N;
	}

};

int main()
{
    int opt,spec;

    char name[20];
	char personal_info[20];
    char curs[N][20];
    float nota[N];

    char spec_curs[20];
	char list_prog[20];
	char field[20];

    do{
        cout<<endl<<"Introduceti numele studentului: ";
        cin>>name;
        cout<<endl<<"Introduceti datele personale ale studentului: ";
        cin>>personal_info;

        for(int i=0;i<N;i++)
        {
            cout<<"Introduceti cursul "<<i+1<<": ";
            cin>>curs[i];
            cout<<"Introduceti nota pentru cursul "<<curs[i]<<": ";
            cin>>nota[i];
        }

        cout<<endl<<"Introduceti specializarea studentului:(0 - software, 1-hardware): ";
        cin>>spec;
        if(spec==0)
        {
            cout<<endl<<"Introduceti spec_curs: ";
            cin>>spec_curs;
            cout<<endl<<"Introduceti list_prog: ";
            cin>>list_prog;
            SoftwareStud ob(name,personal_info,curs,nota,spec_curs,list_prog);
            ob.afisare();
            ob.grade();
        }
        else if(spec==1)
        {
            cout<<endl<<"Introduceti spec_curs: ";
            cin>>spec_curs;
            cout<<endl<<"Introduceti field: ";
            cin>>field;
            HardwareStud ob(name,personal_info,curs,nota,spec_curs,field);
            ob.afisare();
            ob.grade();
        }
        else
        {
            cout<<endl<<"Nu a-ti introdus o cifra corecta!";
        }

        cout<<endl<<"Doriti sa mai introduceti alt student? (0 - Da, alta cifra - Nu): ";
        cin>>opt;

    }while(opt==0);
	return 0;
}
