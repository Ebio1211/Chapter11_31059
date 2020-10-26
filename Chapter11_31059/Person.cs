

//Q2-2  性別判定式
using System;

enum Gender
{
    Male, //男性
    Female //女性
}

// ■リスト10-22：読み取り専用プロパティ（1）
class Person
{
    // 名
    public string FirstName { get; set; }
    // 姓
    public string LastName { get; set; }
    // 姓名
    public string FullName  // getアクセサーだけを持ったプロパティ
    {
        get { return LastName + FirstName; }
    }
    //性別
    public Gender gender { get; set; }



    //Q2-3
    public Person(string FirstName, string LastName,Gender gender)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.gender = gender;
    }





}
