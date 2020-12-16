# Програма виділення вершин, які мають ознаки транзитності

### Створюємо граф на 30 елементів 
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%841.png)

### Реалізація 
```С#
var n01 = new Element("01");
            var n02 = new Element("02");
            var n03 = new Element("03");
            var n04 = new Element("04");
            var n05 = new Element("05");
            var n06 = new Element("06");
            var n07 = new Element("07");
            var n08 = new Element("08");
            var n09 = new Element("09");
            var n10 = new Element("10");
            var n11 = new Element("11");
            var n12 = new Element("12");
            var n13 = new Element("13");
            var n14 = new Element("14");
            var n15 = new Element("15");
            var n16 = new Element("16");
            var n17 = new Element("17");
            var n18 = new Element("18");
            var n19 = new Element("19");
            var n20 = new Element("20");
            var n21 = new Element("21");
            var n22 = new Element("22");
            var n23 = new Element("23");
            var n24 = new Element("24");
            var n25 = new Element("25");
            var n26 = new Element("26");
            var n27 = new Element("27");
            var n28 = new Element("28");
            var n29 = new Element("29");
            var n30 = new Element("30");

            n01.AddAdjacentEl(n02).AddAdjacentEl(n03);
            n02.AddAdjacentEl(n04).AddAdjacentEl(n11);
            n03.AddAdjacentEl(n05);
            n04.AddAdjacentEl(n06, false);
            n06.AddAdjacentEl(n08, false);
            n07.AddAdjacentEl(n17);
            n17.AddAdjacentEl(n16);
            n16.AddAdjacentEl(n08).AddAdjacentEl(n15);
            n11.AddAdjacentEl(n10).AddAdjacentEl(n12);
            n10.AddAdjacentEl(n13, false);
            n09.AddAdjacentEl(n14);
            n14.AddAdjacentEl(n19, false);
            n12.AddAdjacentEl(n13, false);
            n13.AddAdjacentEl(n14).AddAdjacentEl(n21);
            n19.AddAdjacentEl(n18, false);
            n22.AddAdjacentEl(n21).AddAdjacentEl(n23).AddAdjacentEl(n25, false);
            n25.AddAdjacentEl(n26).AddAdjacentEl(n24);
            n26.AddAdjacentEl(n20, false).AddAdjacentEl(n27);
            n27.AddAdjacentEl(n28, false).AddAdjacentEl(n29);
            n28.AddAdjacentEl(n29);
            n30.AddAdjacentEl(n29);
```
## Пошук вершин
### 1 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/1.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%842.png)

### 2 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/2.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%843.png)

### 3 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/3.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%844.png)

### 4 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/4.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%845.png)

### 5 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/5.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%846.png)

### 6 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/6.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%847.png)

### 7 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/7.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%848.png)

### 8 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/8.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%849png.png)

### 9 вершина з ознакою транзитності
![alt text](https://github.com/natasha1237/lab4/blob/main/9.png)
![alt text](https://github.com/natasha1237/lab4/blob/main/%D0%B3%D1%80%D0%B0%D1%8410.png)
