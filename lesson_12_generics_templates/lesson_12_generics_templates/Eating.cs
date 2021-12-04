using System.Collections;

namespace lesson_12_generics_templates
{
    public class Eating<T, TT>
        where T: Fruit
        where TT: IEnumerable
    {
        public int Volume { get; private set; }
        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}