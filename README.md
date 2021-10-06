## __Game Events | Unity__

<b> GameEvents is a package that you can install in your unity projects that can be used to Raise events from anywhere. It's a powerful and useful way of calling events and is most useful when calling those events from scriptable objects! </b>

##### How do I start? 

##### Step 1 
* _Clone the repository and drop the files into your project_
or
* _Run `git clone git@github.com:BradleySeymourSAE/game-events.git`_

##### Step 2
* After adding the files into your project. You can create new events by 
    * Right clicking in the project window
    * Click Create
    * Game Events 
    * Then select an event type from the list 
    * Create a name for it, then continue. 

__See Example.cs for an example of how you would _raise_ an event__

After raising an event, you would probably want something to listen to that event
For instance, updating a score. To do this you click on a game object; 
* Click AddComponent, 
* Type the events _type_ that you want to raise, (VoidEvent, IntegerEvent, etc)
* Here, you want to add an event listener associated with the game event type. 
    * In our case, it would be an IntegerEventListener. 

__After adding the event listener onto the game object, drag the scriptable object that you named earlier into the event slot, then press start to go into play mode__

_I do not take credit for handling game events this way. However, I did draw inspiration from extending the system after watching [Dapper Dino - Scriptable Object Architecture](https://www.youtube.com/watch?v=iXNwWpG7EhM "Scriptable Object Architecture in Unity")_
