import Card from '../ui/Card';
import classes from './ProductItem.module.css';

const ProductItem = (props) => {
    return (
        <li className={classes.item}>
            <Card>
                <div className={classes.image}>
                    <img src={props.image} alt={props.title} />
                </div>
                <div className={classes.content}>
                    <h3>{props.title}</h3>
                    <p>{props.description}</p>
                </div>
                <div className={classes.actions}>
                    <button>Edit</button>
                    <button>Delete</button>
                </div>
            </Card>
        </li>
    );
};

export default ProductItem;
