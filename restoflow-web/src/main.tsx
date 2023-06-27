import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import { Flowbite } from 'flowbite-react'
import './index.css'

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <React.StrictMode>
    <Flowbite>
      <App />
    </Flowbite>
  </React.StrictMode>
)
