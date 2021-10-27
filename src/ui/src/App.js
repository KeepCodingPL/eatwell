import { Route, Switch } from 'react-router';

import MainNavigation from './components/layout/MainNavigation';
import AllProductsPage from './pages/AllProducts';
import NewProductPage from './pages/NewProduct';
import Layout from './components/layout/Layout';

function App() {
    return (
        <Layout>
            <Switch>
                <Route exact path="/">
                    <AllProductsPage />
                </Route>
                <Route path="/new-product">
                    <NewProductPage />
                </Route>
            </Switch>
        </Layout>
    );
}

export default App;
