public class Client
{
    private string accessToken;
    private string merchantID;

    protected T fetch<T>(string path)
    {
        // TODO
    }

    protected T[] fetchPaginated<T>(string path)
    {
        // TODO
    }

    public User getUser()
    {
        // TODO
    }

    public Payment[] listPayments()
    {
        // TODO
    }

    public Item[] ListItems()
    {
        // TODO
    }

    public Refund[] ListRefunds()
    {
        // TODO
    }

    public InventoryEntry[] ListInventory()
    {
        // TODO
    }
}
