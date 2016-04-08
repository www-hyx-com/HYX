# www.design-pattern.com

## 面向对象设计原则
### 一、单一职责原则（Single Response Principle，SRP）
* 核心思想：解耦和增强内聚性（高内聚，低耦合）。
* 描述：类被修改的几率很大，因此应该专注于单一的功能。如果你把多个功能放 在同一个类中，功能之间就形成了关联，改变其中一个功能，有可能中止另一个功能，这时就需要新一轮的测试来避免可能出现的问题。

### 二、开闭原则（Open-Closed Principle,OCP）
* 核心思想：对扩展开放，对修改关闭。即在设计一个模块的时候，应当使这个模 块可以在不被修改的前提下被扩展。
* 根据开闭原则，在设计一个软件系统模块（类，方法）的时候，应该可以在不修改原有的模块（修改关闭）的基础上，能扩展其功能（扩展开放）。
* 扩展开放：某模块的功能是可扩展的，则该模块是扩展开放的。软件系统的功能上的可扩展性要求模块是扩展开放的。
* 修改关闭：某模块被其他模块调用，如果该模块的源代码不允许修改，则该模块修改关闭的。软件系统的功能上的稳定性，持续性要求是修改关闭的。
* 开闭原则的实现方法 为了满足开闭原则的对修改关闭（closed for modification）原则以及扩展开放（open for extension）原则，应该对软件系统中的不变的部分加以抽象，在面向对象的设计中：
1. 可以把这些不变的部分加以抽象成不变的接口，这些不变的接口可以应对未来的扩展。
2. 接口的最小功能设计原则。根据这个原则，原有的接口要么可以应对未来的扩展。
3. 不足的部分可以通过定义新的接口来实现。
4. 模块之间的调用通过抽象接口进行，这样即使实现层发生变化，也无需修改调用方的代码。
* 接口可以被复用，但接口的实现却不一定能被复用。接口是稳定的，关闭的，但接口的实现是可变的，开放的。可以通过对接口的不同实现以及类的继承行为等为系统增加新的或改变系统原来的功能，实现软件系统的柔软扩展。
* 简单地说，软件系统是否有良好的接口（抽象）设计是判断软件系统是否满足开闭原则的一种重要的判断基准。现在多把开闭原则等同于面向接口的软件设计。

#### >开闭原则的相对性
* 软件系统的构建是一个需要不断重构的过程，在这个过程中，模块的功能抽象，模块与模块间的关系，都不会从一开始就非常清晰明了，所以构建100%满足开闭原则的软件系统是相当困难的，这就是开闭原则的相对性。但在设计过程中，通过对模块功能的抽象（接口定义），模块之间的关系的抽象（通过接口调用），抽象与实现的分离（面向接口的程序设计）等，可以尽量接近满足开闭原则。

### 三、里氏替换原则（Liskov Substitution Principle,LSP）
* 核心思想： 在任何父类出现的地方都可以用他的子类来替代（子类应当可以替换父类 并出现在父类能够出现的任何地方）。
* 四层含义：
* （1）子类必须完全实现父类的方法。在类中调用其他类是务必要使用父类或接口，如果不能使用父类或接口，则说明类的设计已经违背了 LSP 原则。
* （2）子类可以有自己的个性。子类当然可以有自己的行为和外观了，也就是方法和属性。
* （3）覆盖或实现父类的方法时输入参数可以被放大。即子类可以重载父类的方法，但输入参数应比父类方法中的大，这样在子类代替父类的时候调用的仍然是父类的方法。 即以子类中方法的前置条件必须与超类中被覆盖的方法的前置条 件相同或者更宽松。
* （4）覆盖或实现父类的方法时输出结果可以被缩小。

### 四、依赖倒转原则（Dependence Inversion Principle,DIP）
* 核心思想：要依赖于抽象，不要依赖于具体的实现。
* 三层含义：
* （1）高层模块不应该依赖低层模块，两者都应该依赖其抽象（抽象类或接口）。
* （2）抽象不应该依赖细节（具体实现）。
* （3）细节（具体实现）应该依赖抽象。
* 三种实现方式：
* 1、通过构造函数传递依赖对象。
* 2、通过 setter 方法传递依赖对象。
* 3、接口声明实现依赖对象。
* 表现：
* （1）模块间的依赖是通过抽象发生，实现类之间不发生直接的依赖关系，其依 赖关系是通过接口或抽象类产生的。
* （2）接口或抽象类不依赖于实现类。
* （3）实现类依赖接口或抽象类。

### 五、接口隔离原则（Interface Segregation Principle,ISP）
* 核心思想：不应该强迫客户程序依赖他们不需要使用的方法。接口分离原则的意思就是：一个接口不需要提供太多的行为， 一个接口应该只提供一种对外的功能，不应该把所有的操作都封装到一个接口当中接口隔离原则的定义。
* 第一种定义：客户端不应该依赖它不需用的接口。
* 第二种定义：一个类对另外一个类的依赖性应当是建立在最小的接口上的。
* 接口分以下两种：
1.对象接口（Object Interface） 声明一个类，通过 new 关键字产生的一个实例，对一个类型事物的描述，也是一种接口。
2.类接口（Class Interface） 通过关键字 Interface 定义的接口。
* 分离接口的两种实现方法：
1.使用委托分离接口。（Separation through Delegation） 就把请求委托给别的接口的实现类来完成需要的职责，就是适配器模式 (Adapter)。
2.使用多重继承分离接口。 （Separation through Multiple Inheritance。） 该方法通过实现多个接口来完成需要的职责。
* 两种方式各有优缺点，通常我们应该先考虑后一个方案，如果涉及到类型转换时则选择前一个方案。

### 六、迪米特法则（Law of Demeter，LoD或LKP（Least Knowledge Principle））
* 核心思想：一个对象应当对其他对象有尽可能少的了解,不和陌生人说话。（类间解耦，低耦合）意思就是降低各个对象之间的耦合，提高系统的可维护性。在模块之间只通过接口来通信，而不理会模块的内部工作原理，可以使各个模块的耦合程度降到最低，促进软件的复用。
* 在将迪米特法则运用到系统的设计中时，应注意的几点：
1.在类的划分上，应该创建有弱耦合的类。
2.在类的结构设计上，每一个类都应当尽量降低成员的访问权限。
3.在类的设计上，只要有可能，一个类应当设计成不变类。
4.在对其他类的引用上，一个对象对其它对象的引用应当降到最低。
5.尽量降低类的访问权限。
6.谨慎使用序列化功能。
7.不要暴露类成员，而应该提供相应的访问器(属性)。
* 优点： 
1.迪米特法则的初衷在于降低类之间的耦合。由于每个类尽量减少对其他类的依赖，因此，很容易使得系统的功能模块功能独立，相互之间不存在（或很少有）依赖关系。
2.遵循迪米特法则会使一个系统的局部设计简化，因为每一个局部都不会和远距离的对象有直接关联。
* 缺点：
1.会在系统里造出大量的小方法，散落在系统的各个角落。这些方法仅仅是传递间接的调用，因此与系统的商务逻辑无关，当设计师试图从一张类图看出总体的框架时，这些小的方法会造成迷惑和困扰。
2.会造成系统的不同模块之间的通信效率降低，也会使系统的不同模块之间不容易协调。
* 设计模式中的应用：
1.门面模式(Facade Pattern)
2.中介模式(Mediator Pattern) 

### 七、合成/聚合复用原则（Composite/Aggregate Reuse Principle，CARP）
* 核心思想：尽量使用对象组合，而不是继承来达到复用的目的。该原则就是在一个新的对象里面使用一些已有的对象，使之成为新对象的一部分，新的对象通过向这些对象的委派达到复用已有功能的目的。
* 术语：
1.聚合（Aggregation）：聚合用来表示“拥有”关系或者整体与部分的关系。
2.合成（Composition）：合成则用来表示一种强得多的“拥有”关系。在一个合成关系里面，部分和整体的生命周期是一样的。
* 复用的种类：
1.继承
>优点：新的实现较为容易，因为基类的大部分功能可以通过继承关系自动进入派生类， 修改或扩展继承而来的实现较为容易。
>缺点：继承复用破坏封装，因为继承将基类的实现细节暴露给派生类，这种复用也称为白箱复用。如果基类的实现发生改变，那么派生类的实现也不得不发生改变。从基类继承而来的实现是静态的，不可能在运行时发生改变，不够灵活。
2.合成聚合
>优点：新对象存取成分对象的唯一方法是通过成分对象的接口，这种复用是黑箱复用，因为成分对象的内部细节是新对象所看不见的，这种复用支持封装，这种复用所需的依赖较少，每一个新的类可以将焦点集中在一个任务上。这种复用可以在运行时动态进行，新对象可以使用合成/聚合关系将新的责任委派到合适的对象。
>缺点：通过这种方式复用建造的系统会有较多的对象需要管理。
* 在复用时应优先考虑使用合成聚合而不是继承，而判定的判断为以下四个条件： 1.派生类是基类的一个特殊种类，而不是基类的一个角色，即要分清"Has-A" 和"Is-A"的区别。
2.永远不会出现需要将派生类换成另一个类的派生类的情况。
3.派生类具有扩展基类的责任，而不是具有置换或者注销掉基类的责任。
4.只有在分类学角度有意义时，才可以使用继承。
