import Axios from 'axios'
import ReactDOM from 'react-dom/client'
import { Flowbite } from 'flowbite-react'
import { createBrowserRouter, RouterProvider } from 'react-router-dom'
import { Login } from './pages/login'
import { Root } from './pages/root'
import { Home } from './pages/home'
import { Register } from './pages/register'
import './index.css'
import { configure } from 'axios-hooks'
import { AuthContextProvider } from './context/AuthContext'
import { Products } from './pages/products'

const getJWT = () => {
  const userString = localStorage.getItem('user')
  const jwt = userString ? JSON.parse(userString)?.token : null

  console.log('jwt', userString)
  return jwt
}

const axios = Axios.create({
  baseURL: 'https://localhost:44329/api/',
  headers: {
    Authorization: `Bearer ${getJWT()}`,
    'Content-Type': 'application/json',
  },
})
configure({ axios })

const router = createBrowserRouter([
  {
    path: '/',
    element: <Root />,
    children: [
      {
        path: '/home',
        element: <Home />,
      },
      {
        path: '/products',
        element: <Products />,
      },
    ],
  },
  {
    path: '/login',
    element: <Login />,
  },
  {
    path: '/register',
    element: <Register />,
  },
])

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <Flowbite>
    <AuthContextProvider>
      <RouterProvider router={router} />
    </AuthContextProvider>
  </Flowbite>
)
