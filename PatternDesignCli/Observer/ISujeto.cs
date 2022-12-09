

public interface  ISujeto {

    public void addSubscriber(ISubscriptor sub);
    
    public void removeSubscriber(ISubscriptor sub);

    public void notify(Pedido pedido);

}