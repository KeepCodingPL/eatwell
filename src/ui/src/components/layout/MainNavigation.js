import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import ProductEditModal from '../ui/ProductEditModal';
import { Button } from 'reactstrap';

import classes from './MainNavigation.module.css';

const MainNavigation = () => {

    const [isActive, setIsActive] = useState(false);

    function toggle() { setIsActive(!isActive) };

    return (
        <header className={classes.header}>
            <div className={classes.logo}>Eat Well</div>
            <nav>
                <ul>
                    <li>
                        <Link to="/">All Products</Link>
                    </li>
                    <li>
                    <Link to="" onClick={toggle}>Add New Product</Link>
                        { isActive && <ProductEditModal /> }
                    </li>
                </ul>
            </nav>
        </header>
    );
};

export default MainNavigation;
