## Estructura

```plantuml
@startuml

class Cliente {}

note top of Cliente {
    var publisher = new ConcretePublisher();
    var subscriber = new ConcreteSubscriber()

    publisher.addSubscriber(subscriber);

    publisher.notify(); 
}

abstract IPublisher {
   subscribers[]: ISubscriber
   addSubscriber(ISubscriber)
   removeSubscriber(ISubscriber)
   notify()
}

class ConcretePublisher {
    addSubscriber()
    removeSubscriber()
    notify()
}

note left of ConcretePublisher::notify {
    foreach(subscriber in subscribers)
        subscriber.update();
}

interface ISubscriber {
    update()
}

class ConcreteSubscriber {
       publisherConcreto: ConcretePublisher
       estadoSubscriber
       update()
}

note right of ConcreteSubscriber::estadoSubscriber {
    estadoSubscriber = sujetoConcreto.getEstado();
}

ISubscriber <|.. ConcreteSubscriber
IPublisher <|.. ConcretePublisher
IPublisher o-> "0*" ISubscriber
ConcretePublisher <- ConcreteSubscriber
IPublisher <-- Cliente 
Cliente .> ConcreteSubscriber
@enduml
```

### Detalles

- Define una dependencia uno-a-muchos entre objetos, de modo que cuando cambia el estado de un objeto, todos sus dependientes automaticamente son notificados y actualizados

- Acoplamiento minimo entre Publisher y Subscribers

- Publisher no necesita conocer las clases concretas de Subscribers

- Subscribers pueden añadirse sin modificar el Publisher

### Estructura Pull vs Push

- En la estructura **pull**, el metodo polimorfico actualizar() **(*Puede tener otro nombre especifico*)** manda por parametro el publisherConcreto, para despues realizarle las peticiones necesarias para obtener los datos que quiere actualizar el observador.

- En la estructura **push**, el metodo polimorfico actualizar() manda por parametro cada uno de los datos necesarios por el observador, evitando las peticiones siguientes.





## Secuencia

```plantuml
@startuml

entity cliente
entity ConcretePublisher 
entity ConcreteSubscriber1
entity ConcreteSubscriber2


cliente -> ConcretePublisher : setEstado()
ConcretePublisher ->  ConcretePublisher : notificar()
ConcretePublisher -> ConcreteSubscriber1 : actualizar()
ConcretePublisher -> ConcreteSubscriber2 : actualizar()
@enduml
```
