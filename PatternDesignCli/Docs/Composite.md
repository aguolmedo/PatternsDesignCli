<img title="" src="file:///C:/Users/agual/AppData/Roaming/marktext/images/2022-11-21-17-31-45-image.png" alt="" width="695">

#### Estructura

```plantuml
@startuml

class Cliente

interface IComponent {
    operacion()

}

class Hoja {
     operacion()

}

class Composite {
    children: Component[]
    añadir(Componente)    
    eliminar(Componente)
    obtenerHijo()
    operacion()
}


IComponent <|.. Composite
IComponent <|.. Hoja
Composite o--> IComponent
Cliente -> IComponent

@enduml
```

#### Detalles

- La interfaz IComponent describe operaciones que son comunes a elementos simples y compuestos

- La Hoja es un elemento basico, no tiene hijos (subelementos)

- El Composite es un elemento que tiene subelementos, los subelementos pueden ser Hojas, o otros Composite. Un Composite no conoce las clases concretas de sus hijos. Funciona con todos los subelementos a traves de la interfaz IComponent

- El cliente funciona con todos los elementos a traves de la interfaz IComponent, de esta manera trabaja de la misma manera tanto con elementos simples (Hojas) como con elementos compuestos (Composite)

#### Caso de estudio Venta Digital

```plantuml
@startuml

class GestorCatalogo {
    catalogo: IComponenteCatalogo
    crearIterador(Object[]): Iterador
    listarCatalogo(): String[][]
}

interface IComponenteCatalogo {
    getDescripcionJerarquia: String[]
}

class CompuestoCatalogo {
    nombre: String
    componente: IComponenteCatalogo
    getNombre(): string
    getDescripcionJerarquia: String[]
    agregarComponente(IComponenteCatalogo): void
    eliminarComponente(IComponenteCatalogo): void
    obtenerHijo(): IComponenteCatalogo 

}

class Articulo {
    activo: boolean
    codigo: String
    titulo: String
    getDescripcionJerarquia: String[]
    getTitulo(): String
}

GestorCatalogo -> IComponenteCatalogo
IComponenteCatalogo <|.. CompuestoCatalogo
IComponenteCatalogo <|.. Articulo
IComponenteCatalogo <..o CompuestoCatalogo
Articulo <|-- Libro
Articulo <|-- Musica
Articulo <|-- Videojuego
Articulo <|-- Pelicula

@enduml
```

#### Secuencia

```plantuml
@startuml

control GestorCatalogo

GestorCatalogo -> GestorCatalogo: listarCatalogo(): String[][]
GestorCatalogo -> CompuestoCatalogo: getDescripcionJerarquia(): String[]
CompuestoCatalogo -> CompuestoCatalogo: getNombre(): String
CompuestoCatalogo -> CompuestoCatalogo: ObtenerHijo(): IComponenteCatalogo
CompuestoCatalogo -> CompuestoCatalgo: getDescripcionJerarquia(): String[]

CompuestoCatalgo -> CompuestoCatalgo: getNombre(): String
CompuestoCatalgo -> CompuestoCatalgo: obtenerHijo(): ICompuestoCatalogo
CompuestoCatalgo -> CompuestoCtalogo: getDescripcionJerarquia: String[]

entity Musica
CompuestoCtalogo -> CompuestoCtalogo: getNombre()
CompuestoCtalogo -> CompuestoCtalogo: obtenerHijo(): IComponenteCatalogo
CompuestoCtalogo -> Musica: getDescripcionJerarquia(): String[]
Musica -> Musica: getTitulo()




@enduml
```

##### Detalles Secuencia

- El metodo polimorfico "getDescripcionJerarquia()" recorrre y devuelve el nombre de todos los elementos de la jerarquia: del catalogo activo, de las **X** secciones de dicho catalogo, de las **Y** subsecciones y de los **Z** articulos que la componen
