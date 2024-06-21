#include <iostream>
#include <string.h>
#include<map>
#include<vector>
#define N 3
using namespace std;

class Student
{
public:
	string name;
	string personal_info;
	map<string,float> mp;
	Student(string nume,string ps,map<string,float> mp)
	{
	    this->name=nume;
        this->personal_info=ps;
        this->mp=mp;
	}
	virtual void afisare()
	{
	    cout<<endl<<"Nume: "<<name;
	    cout<<endl<<"Informatii personale: "<<personal_info;
	    for(map<string,float>::iterator itr=mp.begin();itr!=mp.end();++itr)
        {
            cout<<endl<<"Cursuri: "<<itr->first;
            cout<<endl<<"Note: "<<itr->second;
        }
	}

};

class SoftwareStud:public Student
{
	string spec_curs;
	string list_prog;
public:
	SoftwareStud(string nume,string ps,map<string,float> mp,string spec_c,string l_prog): Student(nume,ps,mp)
	{
	    this->spec_curs=spec_c;
        this->list_prog=l_prog;
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
	    for(map<string,float>::iterator itr=mp.begin();itr!=mp.end();++itr)
        {
            if(temp_good<itr->second)
            {
                temp_good=itr->second;
                temp_course_good=itr->first;
            }
            else if(temp_good>itr->second)
            {
                temp_bad=itr->second;
                temp_course_bad=itr->first;
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
	    int c=0;
	    for(map<string,float>::iterator itr=mp.begin();itr!=mp.end();++itr)
        {
            temp += itr->second;
            c++;
        }

        return temp/c;
	}
};

class HardwareStud:public Student
{
	string spec_curs;
	string field;
public:
	HardwareStud(string nume,string ps,map<string,float> mp,string spec_c,string f):Student(nume,ps,mp)
	{
		this->spec_curs=spec_c;
        this->field=f;
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
	    for(map<string,float>::iterator itr=mp.begin();itr!=mp.end();++itr)
        {
            if(temp_good<itr->second)
            {
                temp_good=itr->second;
                temp_course_good=itr->first;
            }
            else if(temp_good>itr->second)
            {
                temp_bad=itr->second;
                temp_course_bad=itr->first;
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
	    int c=0;
	    for(map<string,float>::iterator itr=mp.begin();itr!=mp.end();++itr)
        {
            temp += itr->second;
            c++;
        }

        return temp/c;
	}

};

int main()
{
    vector<SoftwareStud> v1;
    vector<HardwareStud> v2;

    int opt,spec;

    string name;
	string personal_info;
    map<string,float> mp;
    string spec_curs;
	string list_prog;
	string field;

	string curs;
	float nota;
	float medie,aux;
	string temp;

    do{
        cout<<endl<<"Introduceti numele studentului: ";
        cin>>name;
        cout<<endl<<"Introduceti datele personale ale studentului: ";
        cin>>personal_info;

        for(int i=0;i<N;i++)
        {
            cout<<"Introduceti cursul "<<i+1<<": ";
            cin>>curs;
            cout<<"Introduceti nota pentru cursul "<<curs<<": ";
            cin>>nota;
            mp.insert(pair<string,float>(curs,nota));
        }

        cout<<endl<<"Introduceti specializarea studentului:(0 - software, 1-hardware): ";
        cin>>spec;
        if(spec==0)
        {
            cout<<endl<<"Introduceti spec_curs: ";
            cin>>spec_curs;
            cout<<endl<<"Introduceti list_prog: ";
            cin>>list_prog;
            SoftwareStud ob(name,personal_info,mp,spec_curs,list_prog);
            v1.push_back(ob);
        }
        else if(spec==1)
        {
            cout<<endl<<"Introduceti spec_curs: ";
            cin>>spec_curs;
            cout<<endl<<"Introduceti field: ";
            cin>>field;
            HardwareStud ob(name,personal_info,mp,spec_curs,field);
            v2.push_back(ob);
        }
        else
        {
            cout<<endl<<"Nu a-ti introdus o cifra corecta!";
        }

        cout<<endl<<"Doriti sa mai introduceti alt student? (0 - Da, alta cifra - Nu): ";
        cin>>opt;
        mp.clear();

    }while(opt==0);

    cout<<endl<<endl<<"Afisare studenti software: "<<endl<<endl;
    medie=0;
    for(vector<SoftwareStud>::iterator it=v1.begin();it!=v1.end();it++)
    {
        (*it).afisare();
        cout<<endl<<endl;
        (*it).grade();
        cout<<endl<<endl;
        aux=(*it).average();
        if(medie < aux)
        {
            medie=aux;
        }
    }

    cout<<endl<<endl<<"Cea mai mare medie pentru specializarea Software este: "<<medie<<endl<<endl;

    cout<<endl<<endl<<"Afisare studenti hardware: "<<endl<<endl;
    medie=0;
    for(vector<HardwareStud>::iterator it=v2.begin();it!=v2.end();it++)
    {
        (*it).afisare();
        cout<<endl<<endl;
        (*it).grade();
        cout<<endl<<endl;
        if(medie < aux)
        {
            medie=aux;
        }
    }
    cout<<endl<<endl<<"Cea mai mare medie pentru specializarea Hardware este: "<<medie<<endl<<endl;

	return 0;
}
