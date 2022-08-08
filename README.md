## <p align="center">Найкоротші шляхи на множині перешкод у 2D </p>

### <p align="center">1. Вступ</p>

**Задача.** На заданій множині h перешкод, (являють собою полігони, сумарна кількість вершин яких рівна n) для кожного розташування запитних точок S і T знайти найкоротший шлях між ними. 

**Застосування** Робототехніка, GPS, Gamedev (AI ботів), тощо

### <p align="center">2. Основна частина</p>

Розв'язання задачі найкоротшого шляху переважно складається з двох етапів:

<ul>  
<li>Побудова графу видимості</li>  
<li>Пошук найкоротшого шляху по графу</li>  
</ul>

Граф видимості - це граф взаємної видимості точок простору, зазвичай для безлічі точок та перешкод на евклідовій площині. 
Між точками існує видимість, якшо відрізок між цими точками не перетинає жодну перешкоду. 
Ребра перешкод автоматично входять до графу.

<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/graph.png?raw=true"/>
</p>

<p align="center">Приклад</p>

Побудова графу видимості - найскладніша частина задачі найкоротшого шляху.
Найпопулярніші алгоритми:

Наївний алгоритм $O(n^3)$	
[Алгоритм Лі](http://www.science.smith.edu/~istreinu/Teaching/Courses/274/Spring98/Projects/Philip/fp/algVisibility.htm) $O(n^2*log(n))$

У своїй роботі я обрав наївний, так як він найпростіший та інтуітивно зрозумілий.

Суть проста: для кожної з $n$ точок перевіряється $n - 1$ ребер видимості на перетин з $n$ ребрами перешкод. Якшо перетину немає, заносимо ребро до графу.

Існує [багато](https://uk.wikipedia.org/wiki/%D0%97%D0%B0%D0%B4%D0%B0%D1%87%D0%B0_%D0%BF%D1%80%D0%BE_%D0%BD%D0%B0%D0%B9%D0%BA%D0%BE%D1%80%D0%BE%D1%82%D1%88%D0%B8%D0%B9_%D1%88%D0%BB%D1%8F%D1%85) алгоритмів найкоротшого шляху у графі. У своїй роботі я обрав **алгоритм Дейкстри** $O(n^2)$.

**Сумарна складність алгоритму** = $O(n^3)$

### <p align="center">3. Практична частина</p>

Для виконання практичної роботи, я обрав мову програмування C# та графічну бібліотеку OpenTK, яка надає доступ до інструментів OpenGL.

Програма починається з імпорту та парсингу перешкод,  які зберігаються у вигляді звичайного JSON-файлу.

Введення користувача відбувається за допомогою миші.
Після імпорту в рантаймі відбувається перерахунок найкоротшого шляху.

<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_1.png?raw=true"/>
</p>
<p align="center">Початок програми</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_2.png?raw=true"/>
</p>
<p align="center">JSON-файл з перешкодами</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_3.png?raw=true"/>
</p>
<p align="center">Імпорт</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_5.png?raw=true"/>
</p>
<p align="center">Граф видимості</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Gif2.gif?raw=true"/>
</p>
<p align="center">Приклад роботи</p>
