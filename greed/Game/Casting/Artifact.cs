using System;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to hold it's value.
    /// </para>
    /// </summary>
    class Artifact : Actor
    {
        private int _value;

        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {

        }

        /// <summary>
        /// Returns the value of the artifact. 
        /// </summary>
        public int GetValue()
        {
            return _value;
        }

        /// <summary>
        /// Sets the value of the artifact. Should be either +1 or -1.
        /// </summary>
        public void SetValue(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("point value can't be zero");
            }
            this._value = value;
        }
    }
}