import { Button, DarkThemeToggle, Navbar } from 'flowbite-react'
import logo from '../../public/assets/resto-flow-logo.2.jpg'
import { useNavigate } from 'react-router-dom'

const SubNavbar = () => {
  const navigate = useNavigate()

  const navigateToRegister = () => navigate('/register')
  const navigateToLogin = () => navigate('/login')

  return (
    <Navbar fluid>
      <Navbar.Brand href="https://flowbite-react.com">
        <img alt="Flowbite React Logo" className="mr-3 h-6 sm:h-9" src={logo} />
        <span className="self-center whitespace-nowrap text-xl font-semibold dark:text-white">
          RestoFlow
        </span>
      </Navbar.Brand>
      <div className="flex md:order-2 space-x-3">
        <Button onClick={navigateToRegister}>Register</Button>
        <Button onClick={navigateToLogin}>Login</Button>
        <DarkThemeToggle />
        <Navbar.Toggle />
      </div>
      <Navbar.Collapse>
        <Navbar.Link active href="#">
          <p>Home</p>
        </Navbar.Link>
        <Navbar.Link href="#">About</Navbar.Link>
        <Navbar.Link href="#">Services</Navbar.Link>
        <Navbar.Link href="#">Pricing</Navbar.Link>
        <Navbar.Link href="#">Contact</Navbar.Link>
      </Navbar.Collapse>
    </Navbar>
  )
}

export { Navbar, SubNavbar }
