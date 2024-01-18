namespace ConsoleApp1;

public class MyDictionary<K,V>
{
    public K[] keys;
    public V[] values;

    public MyDictionary()
    {
        keys = new K[0];
        values = new V[0];
    }

    public void Add(K key,V value)
    {
        K[] tempKeys;
        tempKeys = keys;
        V[] tempValues;
        tempValues = values;

        keys = new K[keys.Length + 1];
        values = new V[values.Length + 1];
        for (int i = 0; i < tempKeys.Length; i++)
        {
            keys[i] = tempKeys[i];
            values[i] = tempValues[i];
        }
        
        keys[keys.Length - 1] = key;
        values[values.Length - 1] = value;
        
    }

    public int Count()
    {
        return keys.Length;
    }

    public void Show(K key)
    {
        bool isFind = false;
        for (int i = 0; i < keys.Length; i++)
        {
            if (keys[i].Equals(key))
            {
                Console.WriteLine($"Key: {keys[i]}, Value: {values[i]}");
                isFind = true;
                return;
            }
        }

        if (isFind == false)
        {
            Console.WriteLine(key + " couldn't find.");
        }
    }

    public void RemoveAt(K key)
    {
        int index = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (keys[i].Equals(key))
            {
                index = i;
            }
        }
        
        K[] tempKeys;
        tempKeys = keys;
        V[] tempValues;
        tempValues = values;

        keys = new K[keys.Length -1];
        values = new V[values.Length -1];
        
        for (int i = 0; i < tempKeys.Length; i++)
        {
            if (i == index)
            {
                continue;
            }
            else if (i > index)
            {
                keys[i-1] = tempKeys[i];
                values[i-1] = tempValues[i];
            }
            else
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
        }
        
        
    }
    
    
    
}