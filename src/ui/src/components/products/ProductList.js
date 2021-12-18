import ProductItem from './ProductItem';
import classes from './ProductList.module.css';

const ProductList = (props) => {
    return (
        <>
            <div className={classes.heading}>
                <div>Name</div>
                <div>Explanation</div>
            </div>

            <div className={classes.list}>
                {props.products.map((product) => (
                    <ProductItem
                        key={product.id}
                        id={product.id}
                        title={product.title}
                        description={product.description}
                    />
                ))}
            </div>
        </>
    );
};

export default ProductList;
