namespace PatternDesign.FactoryMethod;

public interface  ISaleFactory
{
    //Creator
    //El creator puede ser una interfaz o tambien una clase abstracta, esto cambia las relaciones, en el caso de una interfaz seria realizacion
    //En el caso de una clase abstracta seria una herencia, la clase abstracta puede servir por ejemplo si necesitamos que el creator tenga algun atributo o algun comportamiento por defecto
    public abstract ISale GetSale();
}