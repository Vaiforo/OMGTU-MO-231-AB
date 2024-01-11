using System;

String name1 = "Цех 1", name2 = "Цех 2", name3 = "Объединенный заводческий цех города Кушкек";

Ceh[] workshops = new Ceh[15];
workshops[0] = new Ceh(name1, 2010, 100);
workshops[1] = new Ceh(name2, 2011, 1100);
workshops[2] = new Ceh(name3, 2010, 800);
workshops[3] = new Ceh(name1, 2012, 90);
workshops[4] = new Ceh(name2, 2012, 1200);
workshops[5] = new Ceh(name3, 2012, 600);
workshops[6] = new Ceh(name1, 2013, 200);
workshops[7] = new Ceh(name2, 2013, 300);
workshops[8] = new Ceh(name3, 2013, 400);
workshops[9] = new Ceh(name1, 2015, 100);
workshops[10] = new Ceh(name2, 2015, 350);
workshops[11] = new Ceh(name3, 2015, 700);
workshops[12] = new Ceh(name1, 2017, 130);
workshops[13] = new Ceh(name2, 2017, 700);
workshops[14] = new Ceh(name3, 2017, 900);

Console.WriteLine("Суммарный объем выпуска образования " + name1 + ": " + workshops[0].getSumYearProduct(name1, workshops));
Console.WriteLine("Суммарный объем выпуска образования " + name2 + ": " + workshops[0].getSumYearProduct(name2, workshops));
Console.WriteLine("Суммарный объем выпуска образования " + name3 + ": " + workshops[0].getSumYearProduct(name3, workshops));
workshops[0].getProductValueOfYears(name1, workshops);
workshops[0].getProductValueOfYears(name2, workshops);
workshops[0].getProductValueOfYears(name3, workshops);

public class Ceh {
    private string Title;
    private int Year;
    private float ProductValue;

    public Ceh(string Title, int Year, int ProductValue) {
        this.Title = Title;
        this.Year = Year;
        this.ProductValue = ProductValue;
    } 

    public void setTitle(string Title) {
        this.Title = Title;
    }
    
    public void setYear(int Year) {
        this.Year = Year;
    }

    public void setProductValue(float ProductValue) {
        this.ProductValue = ProductValue;
    }

    public string getTitle() {
        return Title;
    }
    
    public int getYear() {
        return Year;
    }
    
    public float getProductValue() {
        return ProductValue;
    }

    public float getSumYearProduct(string title, Ceh[] Cehs) {
        float sum = 0;
        foreach (Ceh ceh in Cehs) {
            if (ceh.getTitle() == title) {
                sum += ceh.getProductValue();
            }
        }
        return sum;
    }

    public void getProductValueOfYears(string title, Ceh[] Cehs) {
        Console.WriteLine($"\nИнтенсивность {title}");
        foreach (Ceh ceh in Cehs) {
            if (ceh.getTitle() == title) {
                Console.WriteLine($"{ceh.getYear()} {ceh.getProductValue() / 365}");
            }
        }
    }
}

