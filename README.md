## <p align="center">Shortest Paths in a Set of Obstacles in 2D </p>

### <p align="center">1.  Introduction</p>

**Problem**. Given a set of obstacles represented as polygons with a total of n vertices, find the shortest path between two query points, S and T, for each possible configuration.

**Usage:** Robotics, GPS, Gamedev (AI bots), etc.

### <p align="center">2. Algorithm</p>

Solving the shortest path problem mainly involves two stages:

<ul>  
<li>Constructing the visibility graph</li>  
<li>Finding the shortest path in the graph</li>  
</ul>

The visibility graph is a graph of mutual visibility between points in space, usually for a multitude of points and obstacles on the Euclidean plane. Visibility exists between two points if the line segment connecting them does not intersect any obstacles. Edges of obstacles automatically become part of the graph.

<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/graph.png?raw=true"/>
</p>

<p align="center">Example</p>

Constructing the visibility graph is the most challenging part of the shortest path problem. The most popular algorithms include:

Naive algorithm $O(n^3)$	
[Lee's Algorithm](http://www.science.smith.edu/~istreinu/Teaching/Courses/274/Spring98/Projects/Philip/fp/algVisibility.htm) $O(n^2*log(n))$

In this work, I chose the naive algorithm as it is the simplest and most intuitively understandable.

For each of the $n$ points, check $n - 1$ visibility edges for intersection with $n$ obstacle edges. If there is no intersection, add the edge to the graph.

There are [many](https://uk.wikipedia.org/wiki/%D0%97%D0%B0%D0%B4%D0%B0%D1%87%D0%B0_%D0%BF%D1%80%D0%BE_%D0%BD%D0%B0%D0%B9%D0%BA%D0%BE%D1%80%D0%BE%D1%82%D1%88%D0%B8%D0%B9_%D1%88%D0%BB%D1%8F%D1%85) algorithms for finding the shortest path in a graph. In this work, I chose the **Dijkstra's algorithm** $O(n^2)$.


### <p align="center">3. Practical Part</p>

For the practical implementation, I chose the C# programming language and the OpenTK graphics library, which provides access to OpenGL tools.

The program starts with importing and parsing obstacles, stored in a regular JSON file.

User input is done using the mouse. After importing at runtime, the shortest path is recalculated.

<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_1.png?raw=true"/>
</p>
<p align="center">Program start</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/new.png?raw=true"/>
</p>
<p align="center">JSON file with obstacles</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_3.png?raw=true"/>
</p>
<p align="center">Import</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Screenshot_5.png?raw=true"/>
</p>
<p align="center">Visibility graph</p>
<p align="center">
  <img src="https://github.com/DenDunno/ComputationalGeometry/blob/master/Report/Gif2.gif?raw=true"/>
</p>
<p align="center">Result</p>
