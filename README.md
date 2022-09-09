## SOLID Principles
### What is the SOLID Principle?
- SOLID software principles; It is a set of principles that ensure that the developed software is flexible, reusable, maintainable and understandable, and prevents code duplication.
- SOLID consists of 5 different principles and takes the initials of each.
  - Single Responsibility Principle
  - Open/Closed Principle
  - Liskov Substitution Principle
  - Interface Segregation Principle
  - Dependency Inversion Principle

#### 1. [Single Responsibility Principle](https://github.com/iremakalp/Solid-Principles-Tutorials/blob/master/Single-Responsibility-Principle/Program.cs)
- ***" Each class or method should have only one responsibility "***
- There should not be any part of your software that does more than one different task. In this principle, each class, module, or method in software code is required to do only one job. For example, the class should only contain variables and methods related to its subject.
- Before we start coding, we need to ask ourselves two questions;
  - Should this method be inside this class?
  - Is it the job of this method or class to perform this task?

#### 2. [Open/Closed Principle](https://github.com/iremakalp/Solid-Principles-Tutorials/blob/master/Open-Closed-Principle/Program.cs)
- ***" Classes should be closed to change but open to improvement. "***
- While creating our classes or methods, we need to design by anticipating new requests and developments that may occur in the future. The improvements we will make as a result of new requests and needs that may occur in our project should not affect other systems in our project and should not cause any changes.

#### 3. [Liskov Substitution Principle](https://github.com/iremakalp/Solid-Principles-Tutorials/blob/master/Liskov-Substitution-Principle/Program.cs)
- ***" Functions that use a pointer or reference of the base class should be able to use derived classes from this class without needing extra information. "***
- Subclasses should use all the properties of the superclass they inherit, objects created in subclasses should behave the same when replaced by objects of superclasses, and there should be no unused properties.
- We should be able to use subclasses instead of their derived (superior) classes without making any changes in our code.

#### 4. [Interface Segregation Principle](https://github.com/iremakalp/Solid-Principles-Tutorials/blob/master/Interface-Segregation-Principle/Program.cs)
- ***" Principle of separation of interfaces "***
- The interface is to prevent unnecessary code that will occur as a result of implementation and to make our code more purposeful.
- Instead of gathering all the responsibilities into a single interface, we should create more customized interfaces.

#### 5. [Dependency Inversion Principle](https://github.com/iremakalp/Solid-Principles-Tutorials/blob/master/Dependency-Inversion-Principle/Program.cs)
- ***" In layered architectures, high-level modules should not be directly dependent on lower-level modules. "***
- Dependencies between classes should be as low as possible, especially high-level classes should not depend on lower-level classes.

