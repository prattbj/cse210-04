namespace Game.Casting
{
    /// <summary>
    /// <para>A collection of actors.</para>
    /// <para>
    /// The responsibility of a cast is to keep track of a collection of actors. It has methods for 
    /// adding, removing and getting them by a group name.
    /// </para>
    /// </summary>
    public class Cast
    {
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();

        /// <summary>
        /// Constructs a new instance of Cast.
        /// </summary>
        public Cast()
        {
        }

        /// Adds the given actor to the given group.
        public void AddActor(string group, Actor actor)
        {
            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor))
            {
                actors[group].Add(actor);
            }
        }

        /// Gets the actors in the given group. Returns an empty list if there aren't any.
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        /// Gets all the actors in the cast.
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// Gets the first actor in the given group.
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
            return result;
        }

        /// Removes the given actor from the given group based on the index.
        public void RemoveActor(string group, Actor actor, int index)
        {
            if (actors.ContainsKey(group))
            {
                actors[group].RemoveAt(index);
            }
        }

    }
}