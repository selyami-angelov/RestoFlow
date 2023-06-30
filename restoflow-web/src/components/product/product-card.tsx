import { Button, TextInput } from 'flowbite-react'
import { FaPlus, FaMinus } from 'react-icons/fa'
import { Product } from '../../pages/models'
import { ChangeEventHandler, useState } from 'react'
import img from '../../../public/assets/burger.jpg'

interface Props extends Product {
  onTableSelectClick: (product: Product, quantity: number) => void
}

export default function CardWithDecorativeImage({ onTableSelectClick, ...product }: Props) {
  const [quantity, setQuantity] = useState('1')

  const increaseQty = () => {
    let newQuantity = +quantity
    setQuantity((++newQuantity).toString())
  }

  const decreaseQty = () => {
    let newQuantity = +quantity
    setQuantity(newQuantity > 1 ? (--newQuantity).toString() : '1')
  }

  const handleOnQtyChange: ChangeEventHandler<HTMLInputElement> = (event) => {
    const value = event.target.value
    if (value) {
      setQuantity(value)
    } else {
      setQuantity('1')
    }
  }

  return (
    <div className="w-full max-w-sm bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700">
      <a href="#">
        <img className="p-8 rounded-t-lg" src={img} alt="product image" />
      </a>
      <div className="px-5 pb-5">
        <h5 className="text-xl font-semibold tracking-tight text-gray-900 dark:text-white">{product.name}</h5>
        <p className="font-normal text-gray-700 dark:text-gray-400">{product.description}</p>
        <div className="flex items-center justify-between pt-3 mt-3 border-t">
          <div className="flex items-center justify-between">
            <Button pill color={'failure'} size={'xs'} onClick={decreaseQty}>
              <FaMinus className="h-4 w-4" />
            </Button>
            <TextInput
              value={quantity}
              onChange={handleOnQtyChange}
              className="w-10 ml-1 mr-1"
              id="quantity"
              required
              type="text"
            />
            <Button pill color={'success'} size={'xs'} onClick={increaseQty}>
              <FaPlus className="h-4 w-4" />
            </Button>
          </div>
          <a
            onClick={() => onTableSelectClick(product, +quantity)}
            className="rounded-lg bg-cyan-700 px-5 py-2.5 text-center text-sm font-medium text-white hover:bg-cyan-800 focus:outline-none focus:ring-4 focus:ring-cyan-300 dark:bg-cyan-600 dark:hover:bg-cyan-700 dark:focus:ring-cyan-800"
          >
            <p>Table Select</p>
          </a>
        </div>
      </div>
    </div>
  )
}
