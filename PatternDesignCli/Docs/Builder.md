![](C:\Users\agual\AppData\Roaming\marktext\images\2022-11-21-20-05-49-image.png)

#### Estructura

```plantuml
@startuml

class Cliente {}

note top of Cliente {
    builderConcreto = new BuilderConcretoA()
    director = new Director(builderConcreto)
    director.construir()
    builderConcreto.getResultado()

}

class Director {
    builder: Builder
    construir()
}

note left of Director::construir{
    builder.contruirParte()
}

interface IBuilder {
    construirParte1()
    construirParte2()
}

class BuilderConcretoA {
    resultado: Producto
    construirParte1()
    construirParte2()
    getResultado(): Producto
}

class BuilderConcretoB {
    resultado: Producto
    construirParte1()
    construirParte2()
    getResultado(): Producto
}

Director o.> IBuilder
IBuilder <|.. BuilderConcretoA
IBuilder <|.. BuilderConcretoB
Cliente --> Director
BuilderConcretoA ..> ProductoA
BuilderConcretoB ..> ProductoB

@enduml
```

#### Detalles

- La interfaz constructora declara pasos de constoruccion de producto que todos los tipos de objetos constructores tienen en comun

- Los constructores concretos ofrecen distintas implementaciones de los pasos de construccion. Los constructores concretos pueden crear productos que no siguen la interfaz comun (*Podrian implementar mas pasos?*)

- Los productos son los objetos resultantes. Los productos construidos por distntos objetos constructores no tienen que pertenecer a la misma jerarquia de clases o interfaz.

- La clase Directora define el orden en el que se invocaran los pasos de construccion, por lo que puedes crear y reutilizar configuraciones especificas de los productor.

- El cliente debe asociar uno de los objetos constructores con la clase directora. Normalmente se hace una sola vez mediante los parametros del constructor de la clase directora, que utiliza el objeto constructor para el resto de la construccion.

- Proporciona un control fino del proceso de construccion de objetos completos, que requieren multiples pasos
