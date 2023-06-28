import useAxios from 'axios-hooks'
import { useEffect } from 'react'

export const Products = () => {
  const [{ data }] = useAxios({
    url: '/products',
    method: 'GET',
  })

  useEffect(() => {
    console.log(data)
  }, [data])

  return <>products</>
}
