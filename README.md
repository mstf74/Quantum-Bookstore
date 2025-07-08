 ## OOP Features & Concepts Used
- **Abstraction** : Defined an abstract Book class representing shared book structure, and enforced specific buying behavior through the abstract Buy() method.

- **Encapsulation** : Book details and inventory logic are safely wrapped inside their respective classes, exposing only necessary operations (e.g., through Buy() or RemoveOutdatedBooks()).

- **Inheritance** : Specialized book types like PaperBook, EBook, and ShowcaseBook inherit from the base Book class and extend or override core behavior.

- **Polymorphism** : Used method overriding (e.g., Buy()) to allow different book types to respond differently at runtime based on their specific logic.

- **Constructor Chaining** : Used : base(...) in derived book classes to reuse and extend initialization logic from the base constructor cleanly.

- **Singleton Pattern** : ShippingService and MailService are implemented as singletons to provide centralized, shared utility behavior across the application.

- **Open/Closed Principle** : The system is designed to allow adding new book types or behaviors without modifying existing logic, by relying on abstraction and polymorphism.
## screen shots:
![image alt](https://github.com/mstf74/Quantum-Bookstore/blob/cd56ac369a1efbe56f3b4a7a32cd9c175d5b1fbb/ScreenShots/Screenshot.png) 
