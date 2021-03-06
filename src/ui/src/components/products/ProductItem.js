import React, { useState } from 'react';

import ProductEditModal from '../ui/ProductEditModal';
import classes from './ProductItem.module.css';
import React, { useState } from 'react';
import ProductEditModal from '../ui/ProductEditModal';

const ProductItem = (props) => {
    const [isActive, setIsActive] = useState(false);

    function toggle() {
        setIsActive(!isActive);
    }

    return (
        <li className={classes.item}>
            <div className={classes.content}>
                <h3>{props.title}</h3>
                <p>{props.description}</p>
            </div>
            <div className={classes.actions}>
                <button onClick={toggle}>Edit</button>
                {isActive && (
                    <ProductEditModal
                        productName={props.title}
                        productDescription={props.description}
                    />
                )}
                <button>Delete</button>
            </div>
        </li>
    );
};

export default ProductItem;
