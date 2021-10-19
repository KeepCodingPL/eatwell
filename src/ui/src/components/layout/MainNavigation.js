import { Link } from 'react-router-dom';

import classes from './MainNavigation.module.css';

const MainNavigation = () => {
    return (
        <header className={classes.header}>
            <div className={classes.logo}>Eat Well</div>
            <nav>
                <ul>
                    <li>
                        <Link to="/">All Products</Link>
                    </li>
                    <li>
                        <Link to="/new-product">Add New Product</Link>
                    </li>
                </ul>
            </nav>
        </header>
    );
};

export default MainNavigation;
