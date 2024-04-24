```mermaid
classDiagram
    class IMammal
    <<interface>> IMammal

    class ICanFly
    <<interface>> ICanFly

    Bee --|> Animal
    Bee ..|> ICanFly

    Bat --|> Animal
    Bat ..|> IMammal
    Bat ..|> ICanFly

    Cat --|> Animal
    Cat ..|> IMammal

    Dog --|> Animal
    Dog ..|> IMammal

    Program o--> Animal
    Program --> Dog
    Program --> Cat
    Program --> Bat
    Program --> Bee
```