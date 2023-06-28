import { Outlet } from 'react-router-dom'
import { Navbar, SubNavbar } from '../components/navbar'
import Footer from '../components/footer'

export const Root = () => {
  return (
    <div className="flex flex-col h-screen">
      <SubNavbar />
      <div className="flex-grow">
        <Outlet />
      </div>
      <Footer />
    </div>
  )
}
