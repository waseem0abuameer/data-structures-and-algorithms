# Hashtables
<!-- Short summary or background information -->
The Hashtable class implements a hash table, which maps keys to values. Any non-null object can be used as a key or as a value. To successfully store and retrieve objects from a hashtable, the objects used as keys must implement the hashCode method and the equals method.  

Features of Hashtable

-It is similar to HashMap, but is synchronized.
- Hashtable stores key/value pair in hash table.
- In Hashtable we specify an object that is used as a key, and the value we want to associate to that key. The key is then hashed, and the resulting hash code is used as the index at which the value is stored within the table.
- The initial default capacity of Hashtable class is 11 whereas loadFactor is 0.75.
- HashMap doesn’t provide any Enumeration, while Hashtable provides not fail-fast Enumeration.

Type Parameters:

K – the type of keys maintained by this map
V – the type of mapped values
## Challenge
<!-- Description of the challenge -->
Implement a Hashtable Class with the following methods:
- set
- get 
- contains 
- keys 
- hash


## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Hash tables are often used to implement associative arrays, sets and caches. Like arrays, hash tables provide constant-time O(1) lookup on average, regardless of the number of items in the table. The (hopefully rare) worst-case lookup time in most hash table schemes is O(n)
## API
<!-- Description of each method publicly available in each of your hashtable -->
1. set

 - Arguments: key
 - value Returns: nothing 
 - This method should hash the key, and set the key and value pair in the table, handling collisions as needed. 
 - Should a given key already exist, replace its value from the value argument given to this method.

2. get

1. Arguments: key 
2. Returns: Value associated with that key in the table 

3. contains

 1. Arguments: key 
 2. Returns: Boolean, indicating if the key exists in the table already.

4. keys
Returns: Collection of keys

5. hash
1. Arguments: key 
2. Returns: Index in the collection for that key