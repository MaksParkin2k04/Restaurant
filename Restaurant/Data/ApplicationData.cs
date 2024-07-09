using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class ApplicationData
    {

        public ApplicationData()
        {

            ProductBreakfast = new List<ProductBreakfast>();

            ProductPizzas = new List<ProductPizzas>();

            ProductSnacks = new List<ProductSnacks>();

            Initialize();

        }

        public List<ProductBreakfast> ProductBreakfast { get; private set; }

        public List<ProductPizzas> ProductPizzas { get; private set; }

        public List<ProductSnacks> ProductSnacks { get; private set; }


        private void Initialize()
        {
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Омлет с ветчиной и грибами", "Горячий сытный омлет с поджаристой корочкой, ветчина, шампиньоны и моцарелла", "Завтраки", 165));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(),"Омлет с беконом", "Классическое сочетание горячего омлета с поджаристой корочкой и бекона с добавлением моцареллы и томатов на завтрак ", "Завтраки", 165 ));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Омлет с пепперони", "Сытный и сбалансированный завтрак — омлет с поджаристой корочкой, пикантная пепперони, томаты и моцарелла", "Завтраки", 165));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Омлет сырный", "Горячий завтрак из омлета с поджаристой корочкой, моцарелла, кубики брынзы, сыры чеддер и пармезан", "Завтраки", 165 ));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Чизкейк Банановый с шоколадным печеньем", "Солнечный снаружи и яркий по вкусу внутри. Летняя новинка — нежный чизкейк с бананом и шоколадным печеньем", "Завтраки", 149));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Чизкейк Нью-Йорк", "Мы перепробовали тысячу десертов и наконец нашли любимца гостей — нежнейший творожный чизкейк", "Завтраки", 165));
            ProductBreakfast.Add(new ProductBreakfast(Guid.NewGuid(), "Маффин Три шоколада", "Ну и кекс этот маффин! Он из натурального какао, а внутри — нежная начинка из кубиков белого и молочного шоколада", "Завтраки", 165));

            ///

            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Креветки со сладким чили", "Креветки, ананасы, соус сладкий чили, сладкий перец, моцарелла, фирменный соус альфредо", "Пиццы", 469));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Сырная", "Моцарелла, сыры чеддер и пармезан, фирменный соус альфредо", "Пиццы", 289));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Пепперони фреш", "Пикантная пепперони , увеличенная порция моцареллы, томаты , фирменный томатный соус", "Пиццы", 289));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Двойной цыпленок", "Цыпленок , моцарелла, фирменный соус альфредо", "Пиццы", 349));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Карбонара", "Бекон , сыры чеддер и пармезан , моцарелла, томаты , красный лук , чеснок , фирменный соус альфредо, итальянские травы ", "Пиццы", 469));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Бургер-пицца", "Ветчина , маринованные огурчики , томаты , красный лук , чеснок , соус бургер, моцарелла, фирменный томатный соус", "Пиццы", 469));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Гавайская", "Цыпленок , ананасы , моцарелла, фирменный соус альфредо", "Пиццы", 629));
            ProductPizzas.Add(new ProductPizzas(Guid.NewGuid(), "Диабло", "Острые колбаски чоризо , острый перец халапеньо , соус барбекю, митболы из говядины , томаты , сладкий перец , красный лук , моцарелла, фирменный томатный соус", "Пиццы", 819));


            ///

            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Дэнвич ветчина и сыр", "Поджаристая чиабатта и знакомое сочетание ветчины, цыпленка, моцареллы со свежими томатами, соусом ранч и чесноком", "Закуски", 229));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Дэнвич чоризо барбекю", "Насыщенный вкус острых колбасок чоризо и пикантной пепперони с соусами бургер и барбекю, свежими томатами, маринованными огурчиками, моцареллой и луком в румяной чиабатте", "Закуски", 229));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Паста Карбонара", "Паста из печи с беконом, сырами чеддер и пармезан, томатами, моцареллой, фирменным соусом альфредо и чесноком", "Закуски", 329));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Паста мясная", "Паста из печи с митболами, соусом бургер, моцареллой, фирменным томатным соусом и чесноком", "Закуски", 179));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Куриные наггетсы", "Нежное куриное мясо в хрустящей панировке", "Закуски", 229));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Картофель из печи", "Запеченная в печи картошечка — привычный вкус и мало масла. В составе пряные специи", "Закуски", 229));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Куриные крылья барбекю", "Куриные крылышки со специями и ароматом копчения", "Закуски", 389));
            ProductSnacks.Add(new ProductSnacks(Guid.NewGuid(), "Салат Цезарь", "Цыпленок, свежие листья салата айсберг, томаты черри, сыры чеддер и пармезан, соус цезарь, пшеничные гренки, итальянские травы", "Закуски", 230));
        }
        

    }
}
