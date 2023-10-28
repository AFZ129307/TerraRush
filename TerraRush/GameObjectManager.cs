using System.Collections.Generic;

public class GameObjectManager{

    private static GameObjectManager instance = new GameObjectManager();

    public static GameObjectManager Instance 
    {
        get
        {
            return instance;
        }
    }

    private GameObjectManager()
    {
        AddQueue = new Queue<IProdUnit>();
        RemoveQueue = new Queue<IProdUnit>();
        ActivateQueue = new Queue<IProdUnit>();
        ProductionUnits = new List<IProdUnit>();
        ActiveUnits = new List<IProdUnit>();
    }

    public void Update()
    {
        Add();
        Remove();
    }

    private void Add()
    {
        while(AddQueue.Count > 0)
        {
            ProductionUnits.Add(AddQueue.Dequeue());
        }
        while(ActivateQueue.Count > 0)
        {
            ActiveUnits.Add(ActivateQueue.Dequeue());
        }
    }

    private void Remove()
    {
        while(RemoveQueue.Count > 0)
        {
            ActiveUnits.Remove(RemoveQueue.Dequeue());
        }
    }
    
    public IList<IProdUnit> ProductionUnits{get;}
    public IList<IProdUnit> ActiveUnits{get;}
    private Queue<IProdUnit> AddQueue;
    private Queue<IProdUnit> ActivateQueue;
    private Queue<IProdUnit> RemoveQueue;

    public void ReqAdd(IProdUnit ProdUnit)
    {
        AddQueue.Enqueue(ProdUnit);
    }

    public void ReqActivate(IProdUnit ProdUnit)
    {
        ActivateQueue.Enqueue(ProdUnit);
    }

    public void ReqRemove(IProdUnit ProdUnit)
    {
        RemoveQueue.Enqueue(ProdUnit);
    }
}