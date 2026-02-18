namespace Zoo
{
    public class ZooManager
    {
        private List<Animal> animals = new List<Animal>();

        public void AjouterAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}