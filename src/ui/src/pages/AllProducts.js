import ProductList from '../components/products/ProductList';

const DUMMY_DATA = [
    {
        id: '1',
        title: 'Jack Daniels Old No. 7 Tennessee',
        image: 'https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.D4VLJdqQ01pRam-DKQso6QHaHa%26pid%3DApi&f=1',
        description: 'It is vegan but not halal.',
    },
    {
        id: '2',
        title: 'Johnnie Walker A Song of Ice Game of Thrones GoT Blended Scotch Whisky',
        image: 'https://drinksontherocksclub.com/wp-content/uploads/2021/02/WHISKY-J.W.-A-SONG-OF-ICE-%E2%80%93-GAME-OF-THRONES-750ml-1.png',
        description: 'It is vegan but not halal.',
    },
    {
        id: '3',
        title: 'Nescafé Gold Crema',
        image: 'http://centra.ie/image/var/files/brandbank/7613036079167-6538-d463ce-NESCAFE-GOLD-Crema-Instant-Coffee-200g.jpg',
        description: 'It is vegan and halal.',
    },
    {
        id: '4',
        title: 'Ferrero kinder bueno white 6 Riegel',
        image: 'https://cdn.idealo.com/folder/Product/200471/1/200471170/s1_produktbild_max/ferrero-kinder-bueno-white-6-stk-117g.jpg',
        description: 'It is not vegan but halal.',
    },
    {
        id: '5',
        title: 'Nutella Mini Glas',
        image: 'https://www.schulstart.de/media/image/4d/de/99/80809180KXAf20Ytn9CGc.jpg',
        description: 'It is not vegan but halal.',
    },
    {
        id: '6',
        title: 'Old Friends Gouda',
        image: 'https://media.kaufland-online.de/images/items/300x300/7c776970ca8ceaf592c412863fbfd7be.jpg',
        description: 'It is not vegan but halal.',
    },
    {
        id: '7',
        title: 'Tete de Moine Classic und Reserve AOP Mönchskopfkäse',
        image: 'https://i.ebayimg.com/images/g/mtMAAOxyjxlTKa-U/s-l400.jpg',
        description: 'It is neither vegan nor halal.',
    },
    {
        id: '8',
        title: 'Terre Francescane - Chili-Öl - Extra Natives Olivenöl mit Chili',
        image: 'https://p8t3j4a3.stackpathcdn.com/wp-content/uploads/2021/09/1329602484613759cd0171d0.11656125.jpg',
        description: 'It is vegan and halal. It is oil after all!',
    },
    {
        id: '9',
        title: 'BiFi Carazza-Salami',
        image: 'https://res.cloudinary.com/saas-ag/image/upload/w_1200,h_1200,c_pad,q_auto:best,f_auto/v1601683235/mpreis/products/1613826.jpg',
        description: 'It is not vegan and not halal.',
    },
    {
        id: '10',
        title: 'Amur Beluga Kaviar',
        image: 'https://www.fisch-gruber.at/wp-content/uploads/2013/11/products-amurbeluga_1_2.jpg',
        description: 'It is not vegan but halal.',
    },
];

const AllProductsPage = () => {
    return (
        <section>
            <h1>All Products</h1>
            <ProductList products={DUMMY_DATA} />
        </section>
    );
};

export default AllProductsPage;
