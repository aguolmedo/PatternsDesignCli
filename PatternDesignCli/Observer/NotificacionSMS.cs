

public class NotficacionSMS : ISubscriptor {
    public string subject;

    public string body;

    public NotficacionSMS(string subject, string body) {
        this.subject = subject;
        this.body = body;
    }

    public void update()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Sujeto: {subject} \n Body: {body}";
    }
}